using ServiceDLL;
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


    [Fact]
    public void Invalid_Description_Should_Throw_Format_Exception()
    {
        ServiceRequest request = new ServiceRequest();

        Assert.Throws<FormatException>(() => { request.Description = string.Empty; });
    }

    [Fact]
    public void Description_Should_Resolve_When_Not_Empty_Or_Undefined()
    {
        ServiceRequest request = new ServiceRequest();

        var expected_descrtiption = "This is a very short description";
        request.Description = expected_descrtiption;

        Assert.NotEmpty(request.Description);
        Assert.NotNull(request.Description);
        Assert.Equal(expected_descrtiption, request.Description);
    }
    
    [Fact]
    public void State_Should_Change_To_Completed()
    {
        ServiceRequest request = new ServiceRequest();

        var expected_State = ServiceEnums.State.Completed;
        
        request.State = expected_State;

        Assert.Equal(expected_State, request.State);
    }
    
    [Fact]
    public void Priority_Should_Change_To_Critical()
    {
        ServiceRequest request = new ServiceRequest();

        var expected_Priority = ServiceEnums.Priority.Critical;
        
        request.Priority = expected_Priority;

        Assert.Equal(expected_Priority, request.Priority);
    }
    
    [Fact]
    public void Time_Stamp_Should_Be_Today()
    {
        ServiceRequest request = new ServiceRequest();

        var expected_Date = DateTime.Today;
        
        request.DateCreated = expected_Date;

        Assert.Equal(expected_Date, request.DateCreated);
    }

}