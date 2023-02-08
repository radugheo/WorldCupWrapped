import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { GroupsComponent } from './components/groups/groups.component';
import {MatSidenavModule} from '@angular/material/sidenav';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatListModule} from '@angular/material/list';
import {MatToolbarModule} from '@angular/material/toolbar'; 
import { MatIconModule } from '@angular/material/icon'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './components/login/login.component';
import { KnockoutComponent } from './components/knockout/knockout.component';
import { TeamsComponent } from './components/teams/teams.component';
import { StadiumsComponent } from './components/stadiums/stadiums.component';
import { RefereesComponent } from './components/referees/referees.component';
import { MatchesComponent } from './components/matches/matches.component';
import { RegisterComponent } from './components/register/register.component';
import { PlayersComponent } from './components/players/players.component';
import { ArraySortPipe } from './pipes/sort-by.pipe';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    SidenavComponent,
    GroupsComponent,
    LoginComponent,
    KnockoutComponent,
    StadiumsComponent,
    RefereesComponent,
    TeamsComponent,
    MatchesComponent,
    RegisterComponent,
    PlayersComponent,
    ArraySortPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatSidenavModule,
    MatListModule,
    MatToolbarModule,
    MatIconModule,
    FormsModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomePageComponent, pathMatch: 'full' },
      { path: 'teams', component: TeamsComponent},
      { path: 'players', component: PlayersComponent},
      { path: 'groups', component: GroupsComponent },
      { path: 'knockout', component: KnockoutComponent},
      { path: 'matches', component: MatchesComponent},
      { path: 'stadiums', component: StadiumsComponent},
      { path: 'referees', component: RefereesComponent},
      { path: 'login', component: LoginComponent},
      { path: 'register', component: RegisterComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
