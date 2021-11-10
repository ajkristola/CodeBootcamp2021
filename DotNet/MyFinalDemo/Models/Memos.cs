namespace MyFinalDemo.Models
{
    public class Memos
    {
        public int Id { get; set; }
        public string MemoQuestion { get; set; }
        public string MemoAnswer { get; set; }

                            // A constructor is a special method that is used to initialize objects.
        public Memos()      // The advantage of a constructor, is that it is called when an object of a class is created.
        {

        }
    }
}
