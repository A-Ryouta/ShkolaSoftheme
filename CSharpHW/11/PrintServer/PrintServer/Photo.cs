namespace PrintServer
{
    public class Photo
    {
        public string Photograph { get; }

        public Photo()
        {
            Photograph = "*****";
        }

        public Photo(string p)
        {
            Photograph = p;
        }        
    }
}
