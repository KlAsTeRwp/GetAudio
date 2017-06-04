# GetAudio
Exsample of work with partition view and file download/upload on ASP.NET MVC 5
# Domain
Here are the folowing directories: Model, Entities and Abstract
# Domain.Entities
Here it is model of my enties for database. I use approach Code First
# Domain.Abstract
Here it is interface, that i use later to dependency injection uses Ninject
# Domain.Concrete
Here are the database context, that i use later to work with database, and concrete classes to work with databases uses database context
***
<p><li><a href=http://getaudio.somee.com>Here</a> you can see work of method Index of Home Controller.<br>He show list of partion view, that returned after using method Get(int id).<br>On <a href=http://getaudio.somee.com/Home/Create>this page</a> you can see work of method Create of HomeController, that usefull to upload new Audio File into the database</li></p>
<p><li>Connection to database called "DefaultConnection" and you can see it in WebUI/Web.config</li></p>

