namespace Mushni_assigns.Models;

public static class Repository
{
    private static List<StudentResponse> responses = new List<StudentResponse>();

    public static IEnumerable<StudentResponse> Responses
    {
        get { return responses; }
    }

    public static void AddResponse(StudentResponse response)
    {
        responses.Add(response);
    }
}