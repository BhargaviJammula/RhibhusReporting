import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-root',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    FormsModule,
    DxReportViewerModule
  ],
  templateUrl: './app.component.html',
  styleUrls: [
    "../../node_modules/devextreme/dist/css/dx.light.css",
    "../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class AppComponent {
  cityNames: string[] = ["Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore"];
  title = 'DXReportViewerSample';
  selectedCity: string = "";
  reportUrl: string = 'EmployeeParamReport';
  hostUrl: string = 'http://localhost:5000/';
  // Use this line if you use an ASP.NET MVC backend
  //invokeAction: string = "/WebDocumentViewer/Invoke";
  // Use this line if you use an ASP.NET Core backend
  invokeAction: string = '/DXXRDV';

  submitParameter() {
    this.reportUrl = 'EmployeeParamReport?cityNameParam=' + this.selectedCity;
  }
}
