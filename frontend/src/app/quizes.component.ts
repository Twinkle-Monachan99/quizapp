import { Component, OnInit } from '@angular/core'
import { ApiService } from './api.service'
import { QuestionComponent } from './question.component';


@Component({
    selector: 'quizes',
    templateUrl: './quizes.component.html'
})
export class QuizesComponent  implements OnInit{

    quiz: any = {};
    quizes: any = {};

    constructor(public api: ApiService){
       // console.log("once")
        //this.api.getQuestions().subscribe(res => {
       // this.questions = res             //save questions
       // })
        this.api.getQuizes().subscribe(res => {
                this.quizes = res    
        })
    }
    
    ngOnInit(): void {
        
            this.api.getQuizes().subscribe(res => {
            this.quizes = res             //save questions
        })
    }

    
}