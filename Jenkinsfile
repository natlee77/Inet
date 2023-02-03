pipeline {
    agent any

    stages {
        stage('Check out the git repository') {
            steps {
               git 'https://github.com/natlee77/Inet.git'
            }
        }
         stage('Restore NuGet ') {
            steps {
               bat ' "C:\\ProgramData\\chocolatey\\lib\\NuGet.CommandLine\\tools\\nuget.exe" restore Inet.sln'
            }
        }
         stage('Build VSproject with MSBuild') {
            steps {
          bat '"D:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\MSBuild\\Current\\Bin\\msbuild" Inet.sln /p:Configuration=Debug /p:Platform="Any CPU" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"' }
        }
         stage('Test') {
            steps {
               bat '"C:\\ProgramData\\chocolatey\\lib\\nunit-console-runner\\tools\\nunit3-console.exe"  bin/Debug/net6.0/Inet.dll  '
            }
        }
         stage ("cucumber report"){
            steps{
             cucumber buildStatus: 'null', 
             customCssFiles: '', 
             customJsFiles: '', 
             fileIncludePattern: '**/*.json', 
            
             sortingMethod: 'ALPHABETICAL',
             classifications: [
                    [
                        'key': 'Browser',
                        'value': 'Firefox'
                    ],
                    [
                        'key': 'Platform',
                        'value': 'Windows'
                        ]
                ]
            }
        }
        
    }
}
