import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { DxTabPanelModule, DxTemplateModule } from 'devextreme-angular';
import { FormsModule } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-tabpanel',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule,
    DxTabPanelModule,
    DxTemplateModule
  ],
  templateUrl: './tabpanel.component.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css",
    './tabpanel.component.css'
  ]
})
export class TabpanelComponent {
  cityNames: string[] = ["Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore"];
  selectedCity: string = "";
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;

  // Tab Panel Data
  reportTabs: any[] = [];
  selectedIndex = 0;
  selectedTab: any;

  submitParameter() {
    if (!this.selectedCity) {
      alert('Please select a city!');
      return;
    }

    const newReportUrl = `EmployeeParamReport?cityNameParam=${this.selectedCity}`;

    // Add a new tab dynamically
    this.reportTabs = [...this.reportTabs, {  // Create a new array reference to trigger change detection
      title: `City - ${this.selectedCity}`,
      reportUrl: newReportUrl,
    }];

    // Update selected index and selectedTab
    setTimeout(() => {
      this.selectedIndex = this.reportTabs.length - 1;
      this.selectedTab = this.reportTabs[this.selectedIndex];
    }, 0); // Allow time for the UI to update before changing the tab
  }

  closeTab(index: number) {
    this.reportTabs.splice(index, 1);

    // Adjust selected index if needed
    if (this.selectedIndex >= this.reportTabs.length) {
      this.selectedIndex = Math.max(0, this.reportTabs.length - 1);
    }
    
    // Prevent event propagation to avoid activating the tab when closing it
    event?.stopPropagation();
  }
}
