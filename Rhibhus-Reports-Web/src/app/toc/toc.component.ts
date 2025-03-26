
import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-toc',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule
  ],
  templateUrl: './toc.component.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class TocComponent  {
  cityNames: string[] = ["Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore"];
  title = 'DXReportViewerSample';
  selectedCity: string = "";
  reportUrl: string = 'EmployeeMainReport';
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;

  submitParameter() {
    this.reportUrl = 'EmployeeMainReport?cityNameParam=' + this.selectedCity;
  }
}
