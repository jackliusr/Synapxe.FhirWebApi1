using Ihis.FhirEngine.Core.Handlers.Data;

namespace Synapxe.FhirWebApi1.Data;

public class StudentDataMapper : IFhirDataMapper<StudentModel, Student>
{
    public Student Map(StudentModel resource)
    {
        var student = new Student
        {
            Id = resource.Id.ToString("N"),
            Meta = new Hl7.Fhir.Model.Meta
            {
                VersionId = resource.VersionId.ToString(),
                LastUpdated = resource.LastUpdated,
            },
            Name = resource.Name,
            Email = resource.Email,
            Address = resource.Address,
            Phone = resource.Phone
        };
        return student;
    }

    public StudentModel ReverseMap(Student resource)
    {
        var student = new StudentModel
        {
            Id = long.TryParse(resource.Id, out var id)? id: 0,
            VersionId = int.TryParse(resource.VersionId, out var vid) ? vid : 0,
            LastUpdated = resource.Meta?.LastUpdated,
            Name = resource.Name,
            Email = resource.Email,
            Address = resource.Address,
            Phone = resource.Phone
        };
        return student;
    }
}
