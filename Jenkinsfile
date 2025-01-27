node{
    stage ('checkout code'){
    git branch: 'main', url: 'https://github.com/Reewa56/SpecflowFramework.git'
    }
    stage ('restore nuget'){
    bat 'C:/Users/ravik/Downloads/nuget.exe restore NorthStandardProject.sln'
    }
    stage ('build'){
    bat "\"${tool 'MSBuild'}\" SolutionName.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
    }
    stage ('test'){
    bat 'C:/Users/ravik/.nuget/packages/nunit.consolerunner/3.19.1/tools/nunit3-console.exe NorthStandardProject/bin/Debug/net8.0/NorthStandardProject.dll'
    }
}