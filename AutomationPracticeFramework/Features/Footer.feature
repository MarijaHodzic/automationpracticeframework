Feature: Footer
	Simple calculator for adding two numbers

@mytag
Scenario Outline: User can open links under information section
	When user clikcs on '<information link>' option
	Then correct '<page>' is displayed
	 
Examples: 
| information link            | page                        |
| Specials                    | Price drop                  |
| New products                | New products                |
| Best sellers                | Best sellers                |
| Our stores                  | Our store(s)!               |
| Contact us                  | Contact                     |
| Terms and conditions of use | Terms and conditions of use |
| About us                    | About us                    |
| Sitemap                     | Sitemap                     |

