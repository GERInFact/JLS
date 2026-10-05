using ServiceDLL.Models;

namespace Nordwerk_Test_Suite;

public class ServiceRequestTests
{
    [Fact]
    public void Should_Resolve()
    {
        ServiceRequest request = new ServiceRequest();

        Assert.NotNull(request);
    }

    [Fact]
    public void Should_Throw_Null_Reference()
    {
        ServiceRequest request = null;

        // Assert 
        Assert.Throws<NullReferenceException>(() => request.Title);
    }


    [Fact]
    public void Should_Throw_Title_Format_Exception()
    {
        ServiceRequest request = new ServiceRequest();

        // Assert 
        Assert.Throws<FormatException>(() => { request.Title = ""; });
    }
    
    [Fact]
    public void Title_Should_Resolve_When_Not_Empty_Or_Null()
    {
        ServiceRequest request = new ServiceRequest();

        var expected_title = "This is a very good and long title for a proper description of Nordwerk Services";
        
        request.Title = expected_title;
        
        Assert.NotEmpty(request.Title);
        Assert.NotNull(request.Title);
        Assert.Equal(expected_title, request.Title);
    }
 
}