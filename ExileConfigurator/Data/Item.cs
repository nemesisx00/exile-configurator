using System;

namespace ExileConfigurator.Data
{
	/// <summary>
	/// Class representing a single in-game object for the purposes of generating the necessary
	/// configuration code.
	/// </summary>
	public class Item : IComparable<Item>
	{
		private const string FormatClassString = "class {0}	{{ quality = {1}; price = {2}; }};";
		private const string FormatGroupString = "{0} - {1}";

		public string Mod { get; set; }
		public string Type { get; set; }
		public string Id { get; set; }
		public int Price { get; set; }
		public int Quality { get; set; }
		public string Description { get; set; }

		public Item() { }

		public Item(string mod, string type, string id, int price, int quality)
			: this(mod, type, id, price, quality, string.Empty)
		{ }

		public Item(string mod, string type, string id, int price, int quality, string description)
		{
			Mod = mod;
			Type = type;
			Id = id;
			Price = price;
			Quality = quality;
			Description = description;
		}

		/// <summary>
		/// Generate the class definition string for this Item.
		/// </summary>
		/// <returns></returns>
		public string getClassString()
		{
			var classString = string.Format(FormatClassString, Id, Quality, Price);
			return classString;
		}

		/// <summary>
		/// Generate the organizational group string, consisting of the Mod and Type.
		/// 
		/// This string is generally only used to provide useful human-readable labels
		/// for the groups of items with the same mod and type values.
		/// i.e. comments, vendor menu labels
		/// </summary>
		/// <returns></returns>
		public string getGroupString()
		{
			var group = string.Format(FormatGroupString, Mod, Type);
			return group;
		}

		/// <summary>
		/// Case-insensitive ID comparison
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public bool EqualsId(Item i)
		{
			return string.Equals(Id, i.Id, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Case-insensitive ID comparison
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool EqualsId(string id)
		{
			return string.Equals(Id, id, StringComparison.OrdinalIgnoreCase);
		}

		#region Interfaces

		public int CompareTo(Item other)
		{
			if(other == null)
				return 1;

			return Id.CompareTo(other.Id);
		}

		#endregion
		
		#region Overrides
		
		public override string ToString() { return Id; }

		public override bool Equals(object obj)
		{
			if(obj == null)
				return false;

			var other = obj as Item;
			if(other != null)
			{
				return (Mod != null ? Mod.Equals(other.Mod) : other.Mod != null)
				&& (Type != null ? Type.Equals(other.Type) : other.Type != null)
				&& (Id != null ? Id.Equals(other.Id) : other.Id != null)
				&& Price == other.Price
				&& Quality == other.Quality;
			}

			throw new ArgumentException("Object is not an Item");
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int mult = 23;
				int hash = 17;
				if(Mod != null)
					hash = hash * mult + Mod.GetHashCode();
				if(Type != null)
					hash = hash * mult + Type.GetHashCode();
				if(Id != null)
					hash = hash * mult + Id.GetHashCode();
				hash = hash * mult + Price.GetHashCode();
				hash = hash * mult + Quality.GetHashCode();

				return hash;
			}
		}

		#endregion
	}
}
