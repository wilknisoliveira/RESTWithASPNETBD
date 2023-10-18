pipeline {
    agent any
    parameters {
        string(name: 'BRANCH', defaultValue: 'main', description: 'Branch name')
    }
    
    stages {
        stage('Build and Run') {
            when {
                expression { BRANCH ==~ /(main)/ }
            }
            steps {
                echo 'Running docker-compose'
                sh 'docker-compose up -d --build'
            }
        }
        stage('DockerHub') {
            steps {
                echo 'Creating the tags to the images'
                sh 'docker tag rest-with-aspnet-bd:latest wilknis/rest-with-aspnet-bd:latest'
                sh 'docker tag rest-with-aspnet-bd-db:latest wilknis/rest-with-aspnet-bd-db:latest'
                
                withCredentials([string(credentialsId: 'docker-hub', variable: 'dockerHubPwd')]) {
                    sh 'docker login -u wilknis -p ${dockerHubPwd}'
                    sh 'docker push wilknis/rest-with-aspnet-bd:latest'
                    sh 'docker push wilknis/rest-with-aspnet-bd-db:latest'
                }
            }
        }
    }
}