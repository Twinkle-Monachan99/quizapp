import { Injectable } from "@angular/core"
import { HttpClient } from '@angular/common/http'
import { Subject } from "rxjs";

@Injectable()
export class ApiService {

    private selectedQuestion = new Subject <any>();
    questionSelected = this.selectedQuestion.asObservable();

    private selectedQuiz = new Subject <any>();
    quizSelected = this.selectedQuiz.asObservable();
    constructor( private http:HttpClient) { }
    qId
    question

        getQuestions(qId){
            
               return  this.http.get(`https://localhost:44369/api/questions/${qId}`);
                
        }

        getQuizes(){
            return  this.http.get('https://localhost:44369/api/Quizes');
        }
        getAllQuizes(){
            return  this.http.get('https://localhost:44369/api/Quizes/all');
        }

        postQuestion(question){
                this.http.post ('https://localhost:44369/api/questions',question).subscribe(res => {
                    console.log(res)
                }
                )
            
        }

        putQuestion(question){
            this.http.put (`https://localhost:44369/api/Questions/${question.questId}`,question).subscribe(res => {
                console.log(res)
            }
            )
        }


        postQuiz(quiz){
            this.http.post ('https://localhost:44369/api/quizes',quiz).subscribe(res => {
                console.log(res)
            }
            )
        
         }

        putQuiz(quiz){
            this.http.put (`https://localhost:44369/api/Quizes/${quiz.quizId}`,quiz).subscribe(res => {
                console.log(res)
            }
            )
        }
        

       selectQuestion(question)
        {
            this.selectedQuestion.next(question) //since subject .next to set value and triger event
        } 

        selectQuiz(quiz)
        {   
            this.selectedQuiz.next(quiz) //since subject .next to set value and triger event
        } 

}