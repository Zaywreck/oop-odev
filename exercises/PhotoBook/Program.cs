namespace PhotoBook
{
    public static class Program
    {
        public static void Main()
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.GetNumberPages());
            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine(photoBook1.GetNumberPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();

            Console.WriteLine(bigPhotoBook.getNumberOfPages());
        }
    }
}