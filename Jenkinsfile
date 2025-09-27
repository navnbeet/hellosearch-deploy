pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }
    stage('Docker Build & Push') {
      steps {
        sh 'docker build -t knavneetacr01.azurecr.io/hellosearch:$BUILD_NUMBER .'
        sh 'docker push knavneetacr01.azurecr.io/hellosearch:$BUILD_NUMBER'
      }
    }
    stage('Deploy to AKS') {
      steps {
        sh 'kubectl set image deployment/hellosearch hellosearch=knavneetacr01.azurecr.io/hellosearch:$BUILD_NUMBER'
      }
    }
  }
}
