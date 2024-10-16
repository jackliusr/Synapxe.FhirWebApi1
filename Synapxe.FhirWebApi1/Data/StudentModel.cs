using Ihis.FhirEngine.Data.Models;

namespace Synapxe.FhirWebApi1.Data;

[CustomFhirResource]
[Hl7.Fhir.Introspection.FhirType("Student", "http://hl7.org/fhir/StructureDefinition/Student", IsResource = true)]
public partial class StudentModel: IResourceEntity<long>
{
    //public List<IdentifierEntity> Identifier { get; set;  } = new List<IdentifierEntity>();
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public bool IsHistory { get; set; }
    public int? VersionId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public DateTimeOffset? LastUpdated { get; set; }

}
