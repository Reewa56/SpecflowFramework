node{
    stage ('checkout code'){
    git branch: 'main', url: 'https://github.com/Reewa56/SpecflowFramework.git'
    }
    stage ('restore nuget'){
    bat 'C:/Users/ravik/Downloads/nuget.exe restore NorthStandardProject.sln'
    }
    stage ('build'){
    bat 'dotnet build --configuration Release'
    }
    stage ('test'){
    bat 'C:/Users/ravik/.nuget/packages/nunit.consolerunner/3.19.1/tools/nunit3-console.exe NorthStandardProject/bin/Debug/net8.0/NorthStandardProject.dll'
    }
}