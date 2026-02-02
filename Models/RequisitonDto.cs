namespace Web.Models
{
    public class RequisitonDto
    {
        public string Numero { get; set; }
        public string Solicitante { get; set; }
        public string Area { get; set; }
        public DateTime Data { get; set; }
        List<ItemDto> Itens { get; set; } = [];
    }
}
