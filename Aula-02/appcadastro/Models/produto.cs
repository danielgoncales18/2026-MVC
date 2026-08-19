namespace mvc2026;

public class Produto
{
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public int Quantidade { get; set; }
}
