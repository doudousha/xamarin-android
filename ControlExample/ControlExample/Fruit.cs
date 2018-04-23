namespace ControlExample
{
    public class Fruit
    {
        public Fruit(string name, int imageId)
        {
            Name = name;
            ImageId = imageId;
        }

        // 水果名字
        public string Name { get; set; }
        // 水果图片id
        public int ImageId { get; set; }
    }
}