import { QuestionService } from './question.service';
import { Injectable, EventEmitter } from '@angular/core';
import {Http} from '@angular/http';
import { Question } from '../Question.model';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';

@Injectable()
export class QuestionLoadService {
    constructor(private http: Http, private questionService: QuestionService) { }

  ngOnInit(){
   /*  this.questionsLoaded
    .subscribe(
      (questions:Question[])=>{ 
        this.questions = questions;
        console.log("Srv on init"+this.questions);
       // this.questionsLoaded.emit(this.questions.slice());
    }); */
  }

    addQuestion(Question: Question){
        return this.http.post('http://localhost:63927/api/Questions/Add', Question);
    }

    fetchQuestions(){
        return this.http.get('http://localhost:63927/api/Question/List')
        .map(res=>res.json())
        .do(questions=> this.questionService.setQuestions(questions));
    }
}