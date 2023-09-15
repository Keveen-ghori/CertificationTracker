import { Component, OnInit } from '@angular/core';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { ConfigurationSettings } from 'src/app/core/interfaces/configurationSettings.interfaces';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css'],
})
export class FooterComponent implements OnInit {
  configurationSettings!: ConfigurationSettings;

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.userService
      .ConfigurationSettings()
      .subscribe((response: ApiResponse) => {
        if (response.success && response.content) {
          const settings: any = response.content;

          this.configurationSettings = {
            Version: settings.version,
            isInMaintenanceMode: settings.isInMaintenanceMode,
            Title: settings.title,
            PublishedDate: settings.publishedDate,
            Copyright: settings.copyRight,
            Announcements: settings.announcementText,
          };
        }
      });
  }
}
