namespace ControlExample
{
    public class Fruit
    {
        public Fruit(string name, string imageLink)
        {
            Name = name;
            ImageLink = imageLink;
        }


        // 水果名字
        public string Name { get; set; }
        // 水果图片id
        public string ImageLink { get; set; }
    }
}