namespace The_Copier_Exercise
{
    public class Copier
    {
        IDestination destination;
        ISource source;
        public Copier(IDestination destination, ISource source)
        {
            this.destination = destination;
            this.source = source;
        }
        public void Copy()
        {
            char c = source.GetChar();
            while (c != '\n')
            {
                destination.SetChar(c);
                c = source.GetChar();
            }
        }
    }
}