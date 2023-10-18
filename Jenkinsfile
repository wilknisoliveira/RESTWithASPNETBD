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
    }
}