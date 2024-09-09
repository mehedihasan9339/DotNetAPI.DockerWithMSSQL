# DotNetAPI.DockerWithMSSQL

This repository contains a simple ASP.NET Core C# Web API project with a Microsoft SQL Server (MSSQL) database. This project demonstrates how to use ASP.NET Core, MSSQL, and Docker together.

## Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop) (version 4.28.0 or later) installed and running.
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later.

## Project Setup

### Create and Configure the Project

1. **Create a New Project**:
   - Open Visual Studio 2022.
   - Create a new ASP.NET Core Web API project.

2. **Add Docker Support**:
   - Right-click on the project in Solution Explorer.
   - Navigate to `Add` > `Docker Support`.
   - Choose `Linux` and click `OK`.

   This will generate a `docker-compose.yml` file, a `Dockerfile`, and add Docker support to your project.

3. **Check and Modify Configuration**:
   - Open `docker-compose.yml`, `Dockerfile`, and `appsettings.json` to review the Docker configuration.
   - Modify the connection string in `Program.cs` to match the SQL Server configuration.

4. **Run Docker Compose**:
   - Open a terminal and navigate to the project directory.
   - Run the Docker Compose file with the following command:

     ```bash
     docker-compose up
     ```

   This will build and start your Docker containers.

5. **Verify Changes**:
   - Check that changes in your project are reflected in the database.
   - The SQL Server should be accessible at `localhost,8002` with the `sa` password `sa@123456` (as specified in the `docker-compose.yml` file).

### Publish to Docker Hub

1. **Create a Docker Hub Account**:
   - Sign up or log in to [Docker Hub](https://hub.docker.com/).

2. **Publish the Docker Image**:
   - In Visual Studio, right-click on the main project.
   - Select `Publish` and follow the prompts to publish your Docker image to Docker Hub.

   Your image will be available at: [Docker Hub Repository](https://hub.docker.com/repositories/mehedihasan9339).

## Basic Docker Commands

Here are some basic Docker commands you might find useful:

### docker-compose down
### docker-compose up
### docker-compose up --build





<hr>

<p align="center">
  Developer: <a href="mailto:mehedihasan9339@gmail.com">Mehedi Hasan</a>
</p>
