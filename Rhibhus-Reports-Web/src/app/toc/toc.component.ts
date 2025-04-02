
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
  roleNames: string[] = ["Doctor", "Nurse", "Staff", "Accountant", "Admin"];
  title = 'DXReportViewerSample';
  selectedCity: string = "";
  selectedrole: string = "";
  reportUrl: string = 'TOCReport';
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;

  submitParameter() {
    this.reportUrl = `TOCReport?cityNameParam=${this.selectedCity}&roleNameParam=${this.selectedrole}`;
}

}
