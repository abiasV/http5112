## Web Development lab

![Web Development lab](_readme/Web-Development-Lab1.jpg )


## Description
Instructor: Christine Bittle (christine.bittle@humber.ca)
Instructor: Jemi Choi (jemi.choi@humber.ca)

### Link
[Link ](https://google.com/)

### Please read carefully

> [!IMPORTANT]  
This lesson includes ASP.net and DataBase

> [!WARNING]
If you do not attend classes regularly, you will miss.

> [!NOTE]
ASP.ne & DB (mySQL)


> **⚠️ Warning**
>
> Again! Do not miss this class even a day!

> **❌ Error**
>
> Be careful not to be fooled that this course is easy!

> **ℹ️ Information**
>
> Wednesday's Remot class

> **✅ Success**
>
> You must score above 80%


### Code Sample (C#)
```csharp
// HomeController.cs

using Microsoft.AspNetCore.Mvc;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
