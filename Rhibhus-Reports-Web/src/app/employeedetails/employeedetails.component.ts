import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-employeedetails',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule
  ],
  templateUrl: './employeedetails.component.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class EmployeedetailsComponent  {
  title = 'DXReportViewerSample';
  selectedCity: string = "";
  reportUrl: string = 'EmployeeDetailReport';
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;
}
