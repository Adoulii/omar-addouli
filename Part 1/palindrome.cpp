



#include <string>
#include <sstream>
#include <boost/algorithm/string.hpp>
#include <algorithm>
#include <cctype>
#include <iostream>
#include <string>
    // function to remove spaces for a string 
    string RemoveSpaces(const std::string& str) {
        std::string out;                 
        std::string word;                
        std::istringstream ss(str);      
        while(ss >> word) {              
            if(!out.empty()) out += ' '; 
            out += word;                 
        }
        return out;
    }

    char asciitolower(char in) {
        if (in <= 'Z' && in >= 'A')
            return in - ('Z' - 'z');
        return in;
    }


    bool isPalindrome(string s){
        if(s.length() == 0)
        return false;

    // start by making all teh string lower case
        boost::algorithm::to_lower(s);
        // then remove any special character from the strng
    s.erase(std::remove_if(s.begin(), s.end(),
            [](char c) { return !std::isalpha(c); }),
                s.end());
        // we proceed by removing extra spaces
        string clearedStr = RemoveSpaces(s);
        int i=0;
        int j = clearedStr.length()- 1; 
    
    //using two pointers technique we loop through the string and we stop when the comparaison is false
        while (i<j && i < clearedStr.length()/2 ){
            if(clearedStr[i] == clearedStr[j]){
                i++;
                j--;
            }
            else return false;
        }

    return true;






    }