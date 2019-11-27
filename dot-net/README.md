# Coderetreat .NET Tutorial

### Requirements
* installed Visual studio 2017 and higher or Jetbrains Rider 2019.1 and higher
* dotnet core 2.2 ( in case if you use .net core version)
* NET framework 4.6 ( in case if you use .net framework version)
    
# Description #
The solution has four projects two UnitTests projects and two Console applications for both platforms .net core/.NET framework is your choice of what to use. Each test project has a created class for unit-testing.
You might have noticed attributes : 
`[TestClass]` - this is a special attribute which helps your IDE seeing your tests in Test Explorer window
`[TestMethod]` - this is a special attribute that marks your method as a test method. 
    
#### You can use any Frameworks for unit testing e.g MSTEST/nUnit/xUnit and etc.
## Example 
```
    [TestClass]
    public class SummatorTest
    {
        [TestMethod]
        public void ShouldThrowExceptionIfDividerIsZero()
        {
            int divided = 100;
            int divider = 0;
            Assert.ThrowsException<DivideByZeroException>(() => divided / divider);
        }
    }
```

# Tips and tricks 
* if you have chosen either .net core or .net framework you will be able to hide projects that you won't   use  
  simply clicking RMB (right mouse button)  on  a project that you want to hide and click on `Unload Project` in the context menu;


