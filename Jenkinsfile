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
    bat 'dotnet test'
    }
}