#include <iostream>
using namespace std;
int main()
{
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
	int t; cin >> t;
	while (t--)
	{
		int n; cin >> n;
	int a[10000];
	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
	} 
	string s; cin >> s;int oke = 1;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (a[i] == a[j] && s[i] != s[j])
			{
				oke = 0;
			}
		}
        ///1232qwdas
        
        ads
        er/q/wer/qwerqwerqwe
        ///qwer//q/we/r
        //qwerqwerqwe///
	}
	if (oke)
	{
		cout << "YES\n";
	}
	else
		cout << "NO\n";
	}
	 return 0;
}
