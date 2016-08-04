# postgre-dotnetcore
Building a Simple App with PostgreSQL, ASP.NET Core and EF Core in Docker
Build the image:
<ul>
<li>$ docker build -f dockerfile -t postgre-dotnetcore .</li>
</ul>
Start PostgreSQL and ASP.NET Core (link ASP.NET core to ProgreSQL container with legacy linking)
<ul> 
<li>$ docker run -d --name my-postgres -e POSTGRES_PASSWORD=password postgres</li>
<li>$ docker run -d -p 5000:5000 --link my-postgres:postgres postgre-dotnetcore</li>
</ul>
