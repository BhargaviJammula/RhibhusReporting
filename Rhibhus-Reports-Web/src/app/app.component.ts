import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from '../app/navbar/navbar.component';

@Component({
  selector: 'app-root',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule,
    RouterOutlet,
    NavbarComponent
  ],
  template: `<app-navbar></app-navbar>
    <router-outlet></router-outlet>`
})

export class AppComponent {

}
