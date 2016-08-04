# NOTE: Set the DOTNET_VERSION environment variable to the desired version.

# Build the image:
# docker build -t postgre-dotnetcore .
# docker push

# Option 1
# Start PostgreSQL and ASP.NET Core (link ASP.NET core to ProgreSQL container with legacy linking)
 
# docker run -d --name my-postgres -e POSTGRES_PASSWORD=password postgres
# docker run -d -p 5000:5000 --link my-postgres:postgres postgre-dotnetcore

# Option 2: Create a custom bridge network and add containers into it

# docker network create --driver bridge isolated_network
# docker run -d --net=isolated_network --name postgres -e POSTGRES_PASSWORD=password postgres
# docker run -d --net=isolated_network --name aspnetcoreapp -p 5000:5000 postgre-dotnetcore


FROM microsoft/dotnet:1.0.0-preview2-sdk

# Set environment variables
ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Development"

# Copy files to app directory
COPY . /app

# Set working directory
WORKDIR /app

# Restore NuGet packages
RUN ["dotnet", "restore"]

# Open up port
EXPOSE 5000

# Run the app
ENTRYPOINT ["dotnet", "run"]
