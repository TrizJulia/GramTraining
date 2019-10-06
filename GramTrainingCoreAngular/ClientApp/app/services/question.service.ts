import { Injectable, EventEmitter } from '@angular/core';
import {Http} from '@angular/http';
import { Question } from '../Question.model';
import 'rxjs/add/operator/map';
import { Subject } from 'rxjs/Subject';

@Injectable()
export class QuestionService { 
  selectedQuestion: Question;
  questionSelected = new Subject<Question>();
  /* QuestionsLoaded = new EventEmitter<Question[]>(); 
 */
  

  /* ngOnInit(){
    this.QuestionsLoaded
    .subscribe(
      (Questions:Question[])=>{ 
        this.Questions = Questions;
        console.log("Srv on init"+this.Questions);
       // this.QuestionsLoaded.emit(this.Questions.slice());
    });
  } */


  

  /* selectQuestion(id: number){    
      this.selectedQuestion = this.questions[id];
      console.log(id);
      console.log(" from service Questions" + this.questions);
      console.log("selectedQuestion from service" + this.selectedQuestion);
      this.QuestionSelected.emit(this.selectedQuestion);
  } */


  questionsChanged = new Subject<Question[]>();
  private questions: Question[] = [];

  constructor() {}

  setQuestions(questions: Question[]) {
    this.questions = questions;
    this.questionsChanged.next(this.questions.slice());
  }

  getQuestions() {
    return this.questions.slice();
  }

  getQuestion(index: number) {
    return this.questions[index];
  }

  addQuestion(question: Question) {
    this.questions.push(question);
    this.questionsChanged.next(this.questions.slice());
  }

  updateQuestion(index: number, newQuestion: Question) {
    this.questions[index] = newQuestion;
    this.questionsChanged.next(this.questions.slice());
  }

  deleteQuestion(index: number) {
    this.questions.splice(index, 1);
    this.questionsChanged.next(this.questions.slice());
  }
}
