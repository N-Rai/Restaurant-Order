namespace Restuarant_Order.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public Hotness Hotness { get; set; } = Hotness.Zero;
        public Type Type { get; set; }
        public string? Others { get; set; }

        public MenuItem (int id, string name, string? description, string? image, string? others, Hotness hotness, Type type)
        {
            MenuItemId = id;
            Name = name;
            Description = description;
            Image = image;
            Hotness = hotness;
            Type = type;
            Others = others;
        }
    }
    public enum Type
    {
        Starter = 0,
        Main = 1,
        Side = 2,
        Dessert = 3,
        Drink = 4
    }
    public enum Hotness
    {
        Zero = 0,
        Mild = 1,
        Medium = 2,
        Hot = 3,
        ExtraHot = 4,
    }
}
