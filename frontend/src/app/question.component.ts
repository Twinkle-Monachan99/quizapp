import { Component } from '@angular/core'
import { ApiService } from './api.service';
import {ActivatedRoute} from '@angular/router'

@Component({
    selector: 'question',
    templateUrl:'./question.component.html'
})
export class QuestionComponent{
        
         question : any = {};
         //selectedQuest;
         qId
         
        constructor(private api: ApiService ,private route:ActivatedRoute) {
             this.qId=this.route.snapshot.paramMap.get('qId')
             this.api.questionSelected.subscribe(question =>this.question = question) 
        }
        
        ngOnInIt(){
                var quizId=this.route.snapshot.paramMap.get('qId')
                
                this.api.questionSelected.subscribe(question =>this.question = question)   //subscribe to selected observable

         }

        post(question)
        {   
            question.qId=this.qId
            this.api.postQuestion(question)
           // this.selectedQuest=question.text //display quest after clicking post
           
        }
}