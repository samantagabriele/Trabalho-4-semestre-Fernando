namespace AppValidaRa.Models
{
    internal class AlunoModel
    {
        public string Texto { get; set; }

        // Lista de RAs válidos cadastrados
        public List<string> RasValidos { get; } = new List<string>
        {
            "R0957E0",
            "G966JE6",
            "G07FDI7",
            "G95HDE7",
            "G8593D6",
            "G92JEA8"
        };

        // Método para verificar se o RA está cadastrado
        public bool EhRaValido(string ra)
        {
            return RasValidos.Contains(ra.ToUpper());
        }
    }
}