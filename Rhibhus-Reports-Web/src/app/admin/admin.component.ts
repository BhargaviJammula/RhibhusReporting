import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-admin',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule
  ],
  templateUrl: './admin.component.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class AdminComponent {
  cityNames: string[] = ["Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore"];
  countryNames: string[] = ['Malaysia', 'Taiwan', 'Indonesia', 'USA'];
  title = 'DXReportViewerSample';
  selectedCity: string = "";
  selectedCountry: string = "";
  reportUrl: string = 'EmployeeParamReport';
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;

  submitParameter() {
    this.reportUrl = 'EmployeeParamReport?cityNameParam=' + this.selectedCity + '&countryNameParam=' + this.selectedCountry;;
  }
}
