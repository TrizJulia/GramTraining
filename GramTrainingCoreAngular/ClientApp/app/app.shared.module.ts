import { QuestionService } from './services/question.service';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { ListComponent } from './components/list/list.component';
import { QuestionComponent } from './components/list/question/question.component';
import { RulesComponent } from './components/rules/rules.component';
import { HeaderComponent } from './components/header/header.component';
import { AppRoutingModule } from './app-routing.module';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { EditPanelComponent } from './components/edit-panel/edit-panel.component';
import { QuestionsListComponent } from './components/edit-panel/questions-list/questions-list.component';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        ListComponent,
        QuestionComponent,
        RulesComponent,
        HeaderComponent,
        PageNotFoundComponent,
        EditPanelComponent,
        QuestionsListComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        AppRoutingModule        
    ],
    providers: [
        QuestionService
    ]
})
export class AppModuleShared {
}
