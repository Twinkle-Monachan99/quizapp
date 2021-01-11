import { Component, OnInit } from '@angular/core'
import { ApiService } from './api.service'
import {ActivatedRoute} from '@angular/router'


@Component({
    selector: 'questions',
    templateUrl: './questions.component.html'
})
export class QuestionsComponent implements OnInit {

    question: any = {};
    questions: any = {};
        qId
        constructor(private api: ApiService ,private route:ActivatedRoute){
         var quizId=this.route.snapshot.paramMap.get('qId')
        
        this.api.getQuestions(quizId).subscribe(res => {
                this.questions = res             //save questions
        })
    }
    ngOnInit(): void {
        var quizId=this.route.snapshot.paramMap.get('qId')
        //console.log("once")
        this.api.getQuestions(quizId).subscribe(res => {
            this.questions = res             //save questions
        })
    }

   
}