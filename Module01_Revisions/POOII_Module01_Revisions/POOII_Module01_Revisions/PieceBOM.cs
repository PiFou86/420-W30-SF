namespace POOII_Module01_Revisions
{
    public class PieceBOM
    {
        public PieceBOM()
        {
        }

        public string Reference { get; set; }
        public string Description { get; set; }
        public int Nombre { get; set; }

        public override string ToString()
        {
            return $"{this.Description.PadRight(39)} {this.Reference.PadRight(10)} {this.Nombre.ToString().PadRight(10)}";
        }
    }
}