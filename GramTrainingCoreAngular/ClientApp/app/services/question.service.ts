import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Question } from '../question.model';

@Injectable()
export class QuestionService {

  constructor(private http: Http) { }

  getQuestions(){
    this.http.get<Question[]>('/api/Questions/List');
  }
}
