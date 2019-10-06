import { Injectable } from '@angular/core';
import {
  Resolve,
  ActivatedRouteSnapshot,
  RouterStateSnapshot
} from '@angular/router';

import { QuestionService } from './question.service';
import { Question } from '../Question.model';
import { QuestionLoadService } from './questions-load.service';

@Injectable()
export class QuestionsResolverService implements Resolve<Question[]> {
  constructor(
    private questionsLoadService: QuestionLoadService,
    private questionsService: QuestionService
  ) {}

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const questions = this.questionsService.getQuestions();

    if (questions.length === 0) {
      return this.questionsLoadService.fetchQuestions();
    } else {
      return questions;
    }
  }
}
