import { CookieService } from 'ngx-cookie-service';

export function getCookieValue(
  cookieService: CookieService,
  key: string
): string {
  return cookieService.get(key);
}
