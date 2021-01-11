import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import {QuestionComponent} from './question.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import {FormsModule} from '@angular/forms'
import {ApiService} from './api.service'
import {QuestionsComponent} from './questions.component'
import {MatListModule} from '@angular/material/list';
import {HomeComponent} from './home.component'
import {NavComponent} from './nav.component'
import {QuizComponent} from './quiz.component'
import {QuizesComponent} from './quizes.component'
import {PlayComponent} from './play.component'
import {PlayQuizComponent} from './playQuiz.component'
import {MatExpansionModule} from '@angular/material/expansion'
import {MatRadioModule} from '@angular/material/radio'
import {FinishedComponent} from './finished.component'
import {MatDialogModule} from '@angular/material/dialog'

const routes =[
  {path: '',component: HomeComponent},
  {path: 'question',component: QuestionComponent},
  {path: 'question/:quizId',component: QuestionComponent},
  {path: 'questions',component: QuestionsComponent},
  {path: 'quiz',component: QuizComponent},
  {path: 'play',component: PlayComponent},
  {path: 'playQuiz/:quizId',component: PlayQuizComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    QuestionComponent,
    QuestionsComponent,
    HomeComponent,
    NavComponent,
    QuizComponent,
    QuizesComponent,
    PlayComponent,
    PlayQuizComponent,
    FinishedComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule ,
    RouterModule.forRoot(routes),
    AppRoutingModule,
    BrowserAnimationsModule ,
    MatSliderModule , MatInputModule , MatToolbarModule ,
    MatCardModule ,
    FormsModule ,MatListModule ,
    MatExpansionModule,
    MatRadioModule,
    MatDialogModule,
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
  //entryComponents:[FinishedComponent]
})
export class AppModule { }
