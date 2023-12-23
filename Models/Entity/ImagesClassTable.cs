using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Models.Entity;

public partial class ImagesClassTable : Images
{
	public int IdImageClass { get; set; }
    public virtual List<MyClassTable> MyClassTableNavigation { get; set; } = new List<MyClassTable>();
}