import { Injectable, EventEmitter } from '@angular/core';
import {Http} from '@angular/http';
import { Question } from '../question.model';
import 'rxjs/add/operator/map';

@Injectable()
export class QuestionService {
  questions: Question[] = [];
  selectedQuestion: Question;
  questionSelected = new EventEmitter<Question>();
  questionsLoaded = new EventEmitter<Question[]>();

  constructor(private http: Http) { }

  ngOnInit(){
    this.questionsLoaded
    .subscribe(
      (questions:Question[])=>{ 
        this.questions = questions;
        console.log("Srv on init"+this.questions);
       // this.questionsLoaded.emit(this.questions.slice());
    });
  }

  getQuestions(){
   
  }

  addQuestion(question: Question){
      return this.http.post('/api/Questions/Add', question);
  }

  selectQuestion(id: number){    
      this.selectedQuestion = this.questions[id];
      console.log(id);
      console.log(" from service questions" + this.questions);
      console.log("selectedQuestion from service" + this.selectedQuestion);
      this.questionSelected.emit(this.selectedQuestion);
  }

  fetchQuestions(){
    return this.http.get('/api/Question/List')
    .map(res=>res.json());
  }
}
