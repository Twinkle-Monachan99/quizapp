import { Component, OnInit } from '@angular/core'
import { ApiService } from './api.service';


@Component({
    selector: 'play',
    templateUrl:'./play.component.html'
})
export class PlayComponent {
        
       quizes
        
        constructor(private api: ApiService) {
          
            this.api.getAllQuizes().subscribe(res => {
                this.quizes = res             //save questions
                
            })
            
        }
        
        ngOnInIt(){
                
            this.api.getAllQuizes().subscribe(res => {
                this.quizes = res             //save questions
            })

         }

        
}