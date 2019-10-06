import { EditQuestionComponent } from './components/edit-panel/edit-question/edit-question.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListComponent } from './components/list/list.component';
import { RulesComponent } from './components/rules/rules.component';
import { EditPanelComponent } from './components/edit-panel/edit-panel.component';
import {QuestionsResolverService} from './services/questions-resolver.service';


const appRoutes: Routes = [
    { path: '', component: ListComponent, resolve: [QuestionsResolverService] },
    { path: 'rules', component: RulesComponent},
    { path: 'manage', component: EditPanelComponent, resolve: [QuestionsResolverService]},
    { path: 'editQuestion',  component: EditQuestionComponent}
   // { path: '**', redirectTo: '/not-found' } 
];

@NgModule({
    imports: [
      RouterModule.forRoot(appRoutes)
    ],
    exports: [RouterModule]
  })
  export class AppRoutingModule {
  
  }
