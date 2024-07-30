using System.Runtime.InteropServices;
using ConsoleApp1;

namespace PencilKata.Tests;
//using PaperContent;
using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void Write_something_and_it_appears_on_the_page()
    {
        ConsoleApp1.PaperContent.pageContent = "";
       var test = ConsoleApp1.PaperContent.WriteOnPage("this is a test");
       
       // the content of the page should be what is written here
       test.Should().Be("this is a test");
    }
    
    [Fact]
    public void Write_something_on_a_not_blank_page_and_it_combines_them()
    { 
        ConsoleApp1.PaperContent.pageContent = "";
        
       var firstContent = ConsoleApp1.PaperContent.WriteOnPage("this is a test");

       var secondContent = ConsoleApp1.PaperContent.WriteOnPage(" A new thing.");
       
       // the content of the page should be what is written here
       secondContent.Should().Be("this is a test A new thing.");
    }
    
    [Theory]
    [InlineData("Test", 5)]
    [InlineData("something", 1)]
    [InlineData("this is", 4)]
    public void Writing_Something_degrades_a_pencils_strength(string whatIsWritten, int expectedStrength)
    {
        ConsoleApp1.PaperContent.pencilLife = 10;
        var pencilFatigue = ConsoleApp1.PaperContent.fatiguePencil(whatIsWritten);

        ConsoleApp1.PaperContent.pencilLife.Should().Be(expectedStrength);

    }
    
    
    
}