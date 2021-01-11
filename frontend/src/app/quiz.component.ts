import { Component, OnInit } from '@angular/core'
import { ApiService } from './api.service';


@Component({
    selector: 'quiz',
    templateUrl:'./quiz.component.html'
})
export class QuizComponent {
        
         quiz:any={}
        
        constructor(private api: ApiService) {
            
            this.api.quizSelected.subscribe(quiz =>this.quiz = quiz)
           // this.api.questionSelected.subscribe(question =>this.question = question) 
        }
        
        ngOnInIt(){
                
                this.api.quizSelected.subscribe(quiz =>this.quiz = quiz) 

         }

        
}