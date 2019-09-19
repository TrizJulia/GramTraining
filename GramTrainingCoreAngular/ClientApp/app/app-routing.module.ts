import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListComponent } from './components/list/list.component';
import { RulesComponent } from './components/rules/rules.component';
import { EditPanelComponent } from './components/edit-panel/edit-panel.component';


const appRoutes: Routes = [
    { path: '', component: ListComponent },
    { path: 'rules', component: RulesComponent},
    { path: 'manage', component: EditPanelComponent}
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
